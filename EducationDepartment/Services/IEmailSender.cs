using System;
using System.Threading.Tasks;

namespace EducationDepartment.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string name, string Email, string subject, string message);
    }
}
