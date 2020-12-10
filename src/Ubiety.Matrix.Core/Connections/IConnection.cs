namespace Ubiety.Matrix.Core.Connections
{
    public interface IConnection
    {
        void Get();
        void Post();
        void Put();
        void Delete();
    }
}