using ForumApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Core.Contracts
{
	public interface IPostService
	{
        Task AddAsync(PostModel model);
        Task DeleteAsync(int id);
        Task EditAsync(PostModel model);
        Task<IEnumerable<PostModel>> GetAllPostAsync();
        Task<PostModel?> GetByIdAsync(int id);
    }
}
