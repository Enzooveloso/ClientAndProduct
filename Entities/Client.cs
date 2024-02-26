namespace compAndEnum.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public Client() { }
        public Client(string name, string email, DateTime birthDay)
        {
            Name = name;
            Email = email;
            BirthDay = birthDay;
        }
        //
        public override string ToString()
        {
            return Name+ ", ("+ BirthDay.ToString("dd/MM/yyyy")+ ") - "+ Email;
        }
    }
}