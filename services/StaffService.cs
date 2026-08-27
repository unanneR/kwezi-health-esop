using kwezi_health_esop.Models; 

namespace kwezi_health_esop.Services
{
    public class StaffService
    {
        private static readonly List<StaffMember> staffMembers = new()
        {
            new StaffMember {
                Staffid = 1, 
                FullName = "John Doe", 
                Email = "john.doe@example.com",
                posistion = "Manager",
                Unit = "Sales",
            }
        };

        public List<StaffMember> GetAllStaffMembers()
        {
            return staffMembers;
        }

        public StaffMember? GetById(int id)
        {
            return staffMembers.FirstOrDefault(s => s.Staffid == id);
        }   

        public void Add(StaffMember staff)
        {
            staff.Staffid = staffMembers.Any() ? staffMembers.Max(s => s.Staffid) + 1 : 1;
            staffMembers.Add(staff);
        }

        public void Update(StaffMember staff)
        {
            var existingStaff = GetById(staff.Staffid);
            if (existingStaff != null)
            {
                existingStaff.FullName = staff.FullName;
                existingStaff.Email = staff.Email;
                existingStaff.posistion = staff.posistion;
                existingStaff.Unit = staff.Unit;
            }
        }

        public void Delete(int id)
        {
            var staff = GetById(id);
            if (staff != null)
            {
                staffMembers.Remove(staff);
            }
        }

    }
}
