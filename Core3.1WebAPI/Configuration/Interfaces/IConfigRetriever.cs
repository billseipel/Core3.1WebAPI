using Core3._1WebAPI.Configuration;

namespace Core3dot1WebAPI.Configuration.Interfaces
{
    public interface IConfigRetriever
    {
        //Add 'Get' method which returns project specific object 
        public Core3dot1WebAPIConfiguration Get();

    }
}
