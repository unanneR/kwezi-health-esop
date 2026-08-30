using kwezi_health_esop.Models;

namespace kwezi_health_esop.Services
{
    public class StaffService
    {
        private static readonly List<StaffMember> staffMembers = new()
        {
            new StaffMember
            {
                StaffId = 1,
                FullName = "Unanne Radzuma",
                Email = "UnanneRadzuma@gmail.com",
                Position = "Registered Nurse",
                Unit = "ICU"
            },
            new StaffMember
            {
                StaffId = 2,
                FullName = "Random Person",
                Email = "Randomperson@gmail.com",
                Position = "Medical Doctor",
                Unit = "Practioners"
            }
        };

        public List<StaffMember> GetAllStaff()
        {
            return staffMembers;
        }

        public StaffMember? GetById(int id)
        {
            return staffMembers.FirstOrDefault(s => s.StaffId == id);
        }

        public void Add(StaffMember staff)
        {
            staff.StaffId = staffMembers.Any() ? staffMembers.Max(s => s.StaffId) + 1 : 1;
            staffMembers.Add(staff);
        }

        public void Update(StaffMember staff)
        {
            var existingStaff = GetById(staff.StaffId);
            if (existingStaff != null)
            {
                existingStaff.FullName = staff.FullName;
                existingStaff.Email = staff.Email;
                existingStaff.Position = staff.Position;
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