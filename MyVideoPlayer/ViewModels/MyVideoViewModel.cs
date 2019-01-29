using System;
using System.Collections.ObjectModel;
using MyVideoPlayer.Models;

namespace MyVideoPlayer.ViewModels
{
    public class MyVideoViewModel
    {
        public ObservableCollection<MyVideoModel> MyListCollector { get; set; }

        public MyVideoViewModel()
        {
            MyListCollector = new ObservableCollection<MyVideoModel>()
            {
                new MyVideoModel(){ThumbnailUrl ="https://chettrigroup.xyz/wp-content/uploads/2019/01/youtube3.jpg", Title="Microsoft Project Online", ChannelTitle="Dev-Test with Visual Studio Online and Microsoft Azure - Microsoft ...", PublishedAt=DateTime.Now, AuthorCircleImage="https://www.clipartmax.com/png/middle/257-2572603_user-man-social-avatar-profile-icon-man-avatar-in-circle.png", VideoURl="https://chettrigroup.xyz/wp-content/uploads/2019/01/microsoft1.mp4" },
                 new MyVideoModel(){ThumbnailUrl ="https://chettrigroup.xyz/wp-content/uploads/2019/01/youtube2.jpg", Title="Microsoft Project Online", ChannelTitle="Title Test 2", PublishedAt=DateTime.Now, AuthorCircleImage="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTN4I0AGd6B0ikK4mK2VHzeRPR06G8EmXpdWe1k9adSj6VJdm_F", VideoURl="https://chettrigroup.xyz/wp-content/uploads/2019/01/microsoft2.3gpp" },
                 new MyVideoModel(){ThumbnailUrl ="https://chettrigroup.xyz/wp-content/uploads/2019/01/Youtube1.jpg", Title="Microsoft Build Live 2018", ChannelTitle="Building Progressive Web Apps", PublishedAt=DateTime.Now, AuthorCircleImage="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTN4I0AGd6B0ikK4mK2VHzeRPR06G8EmXpdWe1k9adSj6VJdm_F", VideoURl="https://chettrigroup.xyz/wp-content/uploads/2019/01/videoplayback.3gp" },
                  new MyVideoModel(){ThumbnailUrl ="https://chettrigroup.xyz/wp-content/uploads/2019/01/youtube3.jpg", Title="Microsoft Project Online", ChannelTitle="Dev-Test with Visual Studio Online and Microsoft Azure - Microsoft ...", PublishedAt=DateTime.Now, AuthorCircleImage="https://www.clipartmax.com/png/middle/257-2572603_user-man-social-avatar-profile-icon-man-avatar-in-circle.png", VideoURl="https://chettrigroup.xyz/wp-content/uploads/2019/01/microsoft1.mp4" },
                 new MyVideoModel(){ThumbnailUrl ="https://chettrigroup.xyz/wp-content/uploads/2019/01/youtube2.jpg", Title="Microsoft Project Online", ChannelTitle="Title Test 2", PublishedAt=DateTime.Now, AuthorCircleImage="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTN4I0AGd6B0ikK4mK2VHzeRPR06G8EmXpdWe1k9adSj6VJdm_F", VideoURl="https://chettrigroup.xyz/wp-content/uploads/2019/01/microsoft2.3gpp" },
                 new MyVideoModel(){ThumbnailUrl ="https://chettrigroup.xyz/wp-content/uploads/2019/01/youtube3.jpg", Title="Microsoft Build Live 2018", ChannelTitle="Building Progressive Web Apps", PublishedAt=DateTime.Now, AuthorCircleImage="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTN4I0AGd6B0ikK4mK2VHzeRPR06G8EmXpdWe1k9adSj6VJdm_F", VideoURl="https://chettrigroup.xyz/wp-content/uploads/2019/01/videoplayback.3gp" }

            };

        }
    }
}
