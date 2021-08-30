namespace MonumentMlyn.BLL.DTO
{
    public class RoleRequest
    {
        public RoleRequest()
        {
            
        }

        public RoleRequest(string name, string status)
        {
            Name = name;
            Status = status;
        }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}