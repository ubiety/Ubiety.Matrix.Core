using System;
using System.Net.Http;

namespace Ubiety.Matrix.Core.Connections
{
    public class HttpConnection : IConnection, IDisposable
    {
        private HttpClient _client;
        private string _serverUrl;
        private string _userId;
        private bool _disposedValue;

        public HttpConnection(string serverUrl, string userId)
        {
            if (serverUrl.EndsWith('/'))
            {
                serverUrl = serverUrl[..^1];
            }

            _serverUrl = serverUrl;
            _userId = userId;
            _client = new ();
        }

        public HttpConnection(string serverUrl)
            : this(serverUrl, null)
        {
        }
        
        public void Get()
        {
            throw new System.NotImplementedException();
        }

        public void Post()
        {
            throw new System.NotImplementedException();
        }

        public void Put()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool dispose)
        {
            if (!_disposedValue)
            {
                if (dispose)
                {
                    _client?.Dispose();
                    _client = null;
                }

                _disposedValue = true;
            }
        }
    }
}