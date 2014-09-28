using System;
using System.IO;

namespace Monitoring.Storage
{
    public class JSONStore : IStorageHandler
    {
        public JSONStore(String storagePath)
        {
            this.StoragePath = storagePath;
        }

        public String StoragePath;

        public void Store()
        {
        }
    }
}

