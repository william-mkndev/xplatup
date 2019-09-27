using System.IO;
using XplatCollect.Services;

namespace XplatCollect.Droid.Services
{
    public class DataBaseAccessService : IDataBaseAccessService
    {
        public string GetDataBasePath()
        {
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                AppConstants.OFFLINE_DATABASE_NAME);

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }

            return path;
        }
    }
}
