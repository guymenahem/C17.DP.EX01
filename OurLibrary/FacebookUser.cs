using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace OurLibrary
{
    class FacebookUser
    {
        // Facebook user
        private FacebookWrapper.ObjectModel.User m_user;

        public FacebookUser(User i_LoggedInUser)
        {
            
        }

        public string ProfilePictureUrl
        {
            get
            {
                return this.m_user.PictureNormalURL;
            }
        }

        //...
    }
}
