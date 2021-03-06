﻿using System;
using Plaid.Net.Models;
using Plaid.Net.request;
using Plaid.Net.response;
using RestSharp;

namespace Plaid.Net
{
    public class PlaidUserClient : IPlaidUserClient
    {

        public RestClient Client;
        public static string BaseUriProduction = "https://api.plaid.com";
        public static string BaseUriTest = "https://tartan.plaid.com";

        private string _accessToken;
        private readonly string _clientId;
        private readonly string _secret;

        private PlaidUserClient(string clientId, string secret)
        {
            _clientId = clientId;
            _secret = secret;
            Client = new RestClient(BaseUriTest);
        }

        public void SetAccessToken(string accessToken)
        {
            _accessToken = accessToken;
        }

        public string GetAccessToken()
        {
            return _accessToken;
        }

        public TokenResponse ExchangeToken(string publicToken)
        {
            var request = new RestRequest("/exchange_token", Method.POST);
            request.Parameters.Add(new Parameter
            {
                Name = "client_id",
                Value = _clientId
            });
            request.Parameters.Add(new Parameter
            {
                Name = "secret",
                Value = _secret
            });
            request.Parameters.Add(new Parameter
            {
                Name = "public_token",
                Value = publicToken
            });

            var response = Client.Execute(request);
            var responseObject = new TokenResponse(response);

            SetAccessToken(responseObject.GetAccessTokenObject().AccessToken);

            return responseObject;
        }

        public ConnectResponse AuthenticateUser(Credentials credentials, string type, string mfa, ConnectOptions connectOptions)
        {
            var institutions = new InstitutionCategory(new Institutions());

            var request = new RestRequest("/connect", Method.POST);
            request.Parameters.Add(new Parameter
            {
                Name = "client_id",
                Value = _clientId
            });
            request.Parameters.Add(new Parameter
            {
                Name = "secret",
                Value = _secret
            });
            request.Parameters.Add(new Parameter
            {
                Name = "username",
                Value = credentials.UserName
            });
            request.Parameters.Add(new Parameter
            {
                Name = "password",
                Value = credentials.Password
            });

            foreach (var inst in institutions.PinInstitutions())
            {
                if (type.Equals(inst))
                {
                    request.Parameters.Add(new Parameter
                    {
                        Name = "pin",
                        Value = credentials.Pin
                    });
                }
            }

            request.Parameters.Add(new Parameter
            {
                Name = "type",
                Value = type
            });

            request.AddBody(connectOptions);

            var response = Client.Execute(request);

            if ((int) response.StatusCode == (int) HttpStatusCodes.MfaRequired)
            {
                return MfaConnectStep(mfa, type, connectOptions);
            }
            if ((int) response.StatusCode == (int) HttpStatusCodes.Success)
            {
                return new ConnectResponse(response);
            }

            throw new Exception("Neither MFA or Non MFA response");
        }

        public ConnectResponse MfaConnectStep(string mfa, string type, ConnectOptions connectOptions)
        {
            var request = new RestRequest("/connect/step", Method.POST);
            request.Parameters.Add(new Parameter
            {
                Name = "client_id",
                Value = _clientId
            });
            request.Parameters.Add(new Parameter
            {
                Name = "secret",
                Value = _secret
            });
            request.Parameters.Add(new Parameter
            {
                Name = "access_token",
                Value = _accessToken
            });
            request.Parameters.Add(new Parameter
            {
                Name = "type",
                Value = type
            });
            request.Parameters.Add(new Parameter
            {
                Name = "mfa",
                Value = mfa
            });

            request.AddBody(connectOptions);

            var response = Client.Execute(request);

            return new ConnectResponse(response);
        }

        //public AccountsResponse achAuth(Credentials credentials, String type, ConnectOptions connectOptions)
        //{

        //    Map<String, Object> requestParams = new HashMap<String, Object>();
        //    requestParams.put("credentials", credentials);
        //    requestParams.put("type", type);
        //    requestParams.put("options", connectOptions);

        //    return handlePost("/auth", requestParams, AccountsResponse.class)
        //    ;
        //}

        //public AccountsResponse mfaAuthStep(String mfa, String type)
        //{

        //    return handleMfa("/auth/step", mfa, type, AccountsResponse.class)
        //    ;
        //}

        //public AccountsResponse mfaAuthDeviceSelectionByDeviceType(String deviceType, String type)
        //{

        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    if (StringUtils.isEmpty(deviceType))
        //    {
        //        throw new PlaidClientsideException("No device selected");
        //    }

        //    Map<String, Object> requestParams = new HashMap<String, Object>();
        //    requestParams.put("type", type);

        //    HashMap<String, String> mask = new HashMap<String, String>();
        //    mask.put("type", deviceType);
        //    HashMap<String, Object> sendMethod = new HashMap<String, Object>();
        //    sendMethod.put("send_method", mask);
        //    requestParams.put("options", sendMethod);

        //    return handlePost("/auth/step", requestParams, AccountsResponse.class)
        //    ;
        //}

        //public AccountsResponse mfaAuthDeviceSelectionByDeviceMask(String deviceMask, String type)
        //{

        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    if (StringUtils.isEmpty(deviceMask))
        //    {
        //        throw new PlaidClientsideException("No device selected");
        //    }

        //    Map<String, Object> requestParams = new HashMap<String, Object>();
        //    requestParams.put("type", type);

        //    HashMap<String, String> mask = new HashMap<String, String>();
        //    mask.put("mask", deviceMask);
        //    HashMap<String, Object> sendMethod = new HashMap<String, Object>();
        //    sendMethod.put("send_method", mask);
        //    requestParams.put("options", sendMethod);

        //    return handlePost("/auth/step", requestParams, AccountsResponse.class)
        //    ;
        //}

        //public TransactionsResponse updateTransactions()
        //{

        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    PlaidHttpRequest request = new PlaidHttpRequest("/connect", authenticationParams(), timeout);

        //    HttpResponseWrapper<TransactionsResponse> response =
        //        httpDelegate.doGet(request, TransactionsResponse.class)
        //    ;

        //    TransactionsResponse body = response.getResponseBody();
        //    setAccessToken(body.getAccessToken());
        //    return body;

        //}

        //public TransactionsResponse updateTransactions(GetOptions options)
        //{
        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    Map<String, Object> requestParams = new HashMap<String, Object>();
        //    if (options != null)
        //    {
        //        requestParams.put("options", options);
        //    }

        //    return handlePost("/connect/get", requestParams, TransactionsResponse.class)
        //    ;
        //}

        //private @Override 

        //public AccountsResponse updateAuth()
        //{
        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    Map<String, Object> requestParams = new HashMap<String, Object>();

        //    return handlePost("/auth/get", requestParams, AccountsResponse.class)
        //    ;
        //}

        //public TransactionsResponse updateCredentials(Credentials credentials, String type)
        //{

        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    PlaidHttpRequest request = new PlaidHttpRequest("/connect", authenticationParams(), timeout);

        //    request.addParameter("credentials", serialize(credentials));
        //    request.addParameter("type", type);

        //    HttpResponseWrapper<TransactionsResponse> response =
        //        httpDelegate.doPatch(request, TransactionsResponse.class)
        //    ;

        //    TransactionsResponse body = response.getResponseBody();

        //    setAccessToken(body.getAccessToken());

        //    return body;
        //}

        //public TransactionsResponse updateWebhook(String webhook)
        //{

        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    PlaidHttpRequest request = new PlaidHttpRequest("/connect", authenticationParams(), timeout);

        //    ConnectOptions connectOptions = new ConnectOptions();
        //    connectOptions.setWebhook(webhook);

        //    request.addParameter("options", serialize(connectOptions));

        //    HttpResponseWrapper<TransactionsResponse> response =
        //        httpDelegate.doPatch(request, TransactionsResponse.class)
        //    ;

        //    TransactionsResponse body = response.getResponseBody();

        //    setAccessToken(body.getAccessToken());

        //    return body;
        //}

        //public MessageResponse DeleteUser()
        //{

        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    PlaidHttpRequest request = new PlaidHttpRequest("/connect", authenticationParams(), timeout);

        //    HttpResponseWrapper<MessageResponse> response =
        //        httpDelegate.doDelete(request, MessageResponse.class)
        //    ;

        //    return response.getResponseBody();
        //}

        //public AccountsResponse CheckBalance()
        //{

        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    Map<String, Object> requestParams = new HashMap<String, Object>();

        //    return handlePost("/balance", requestParams, AccountsResponse.class)
        //    ;
        //}

        //public TransactionsResponse AddProduct(String product, ConnectOptions options)
        //{

        //    if (StringUtils.isEmpty(accessToken))
        //    {
        //        throw new PlaidClientsideException("No accessToken set");
        //    }

        //    Map<String, Object> requestParams = new HashMap<String, Object>();
        //    requestParams.put("upgrade_to", product);

        //    requestParams.put("login", true);

        //    if (options != null)
        //    {
        //        requestParams.put("options", options);
        //    }

        //    return handlePost("/upgrade", requestParams, TransactionsResponse.class)
        //    ;
        //}

        //public InfoResponse Info(Credentials credentials, String type, InfoOptions options)
        //{
        //    Map<String, Object> requestParams = new HashMap<String, Object>();
        //    requestParams.put("credentials", credentials);
        //    requestParams.put("type", type);
        //    requestParams.put("options", options);

        //    return handlePost("/info", requestParams, InfoResponse.class)
        //    ;
        //}
    }
}
