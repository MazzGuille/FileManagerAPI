using FileManagerAPI.Models;

namespace FileManagerAPI.Repository.Interfaces
{
    public interface IHviRepository
    {
        Task<string> UploadHVI(List<HVI> model/*, string title*/);
        Task<string> UploadHVI2(List<HVI> model/*, string title*/);
        Task<string> UploadHVI3(List<HVI> model/*, string title*/);
        Task<string> UploadHVI4(List<HVI> model/*, string title*/);
    }
}
