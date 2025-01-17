namespace EmployeeMessagingApplication.Models
{
    public class ManageRolesViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<RoleSelectionViewModel> Roles { get; set; }
    }
}
