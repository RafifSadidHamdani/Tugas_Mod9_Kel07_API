using Identity.WebAPI.Models.Dto;

namespace Identity.WebAPI.Data
{
    public static class UserStore
    {
        public static List<UserDTO> userList = new List<UserDTO>
        {
            new UserDTO{Id=1    , Username="Rafif Sadid Hamdani"    , Email="Rafif@gmail.com"   , Password="Rafif"},
            new UserDTO{Id=2    , Username="Juanda Ritonga"         , Email="Juan@gmail.com"    , Password="Juan"},
            new UserDTO{Id=3    , Username="Maulana Yusuf Suradin"  , Email="Yusuf@gmail.com"   , Password="Yusuf"},
            new UserDTO{Id=4    , Username="Hammam Faiz"            , Email="Faiz@gmail.com"    , Password="Faiz"}
        };

    }
}
