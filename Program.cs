using System;
using System.Text;
using Newtonsoft.Json;

namespace jwt_example
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJTYW1hcml0YW4ncyBQdXJzZSIsImlhdCI6MTU4NzEzMTYzNCwiZXhwIjoxNjE4NjY3NjM0LCJhdWQiOiJ3d3cuZXhhbXBsZS5jb20iLCJzdWIiOiJqcm9ja2V0QGV4YW1wbGUuY29tIiwiQWNjb3VudCI6IjEyMzQ1Njc4OSIsIkZpcnN0TmFtZSI6IlJvY2tldCIsIkVtYWlsIjoianJvY2tldEBleGFtcGxlLmNvbSIsIkxhc3ROYW1lIjoiSm9obm55IiwiQXJlYVRlYW0iOiJCbHVlcmlkZ2UgTW91bnRhaW5zIEFyZWEgVGVhbSJ9.XUfrUmdgr_vBMG4uKqjyzB_gAvCCas8OuaMcm2C2oqY";
            string _jwtSecretKey = "qwertyuiopasdfghjklzxcvbnm123456";

            byte[] secretKey = Encoding.ASCII.GetBytes(_jwtSecretKey);
            var payload = Jose.JWT.Decode(token, secretKey);
            var deserializedPayload = JsonConvert.DeserializeObject<JwtPayload>(payload);

            Console.Write($"{deserializedPayload.Account}");

        }
    }

    public class JwtPayload
    {
        public string Account { get; set; }
        public string Email { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AreaTeam { get; set; }
    }
}
