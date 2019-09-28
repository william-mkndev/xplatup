using System;
namespace XplatCollect.Models
{
    public sealed class Person : BaseModel
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Avatar { get; set; }

        public static Person Create(string name, string bio, string avatar)
            => new Person
            {
                Name = name,
                Bio = bio,
                Avatar = avatar
            };
    }
}
