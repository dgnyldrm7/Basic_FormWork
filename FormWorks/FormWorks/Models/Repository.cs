namespace FormWorks.Models
{
    public class Repository
    {

        public static int start = 2;
        //list oluşturmak ,döndürtmek ve eklemek...

        private static List<Profil> _ProfilList = new();

         static Repository()
        {
            _ProfilList.Add(new Profil { Id = 1 , Name = "Dogan" , Email = "dgn@dgn.com" , exampleFormControlSelect1 = true , formFile = "1.jpg"});
            _ProfilList.Add(new Profil { Id = 2 , Name = "Emrah" , Email = "emr@emr.com" , exampleFormControlSelect1 = false , formFile = "2.jpg"});
        }
        
        public static List<Profil> _ShowProfilList { get {  return _ProfilList; } }


        public static void AddProfil(Profil profil)
        {

            profil.Id = start + 1;
            start++;
            _ProfilList.Add(profil);
        }

    }
}
