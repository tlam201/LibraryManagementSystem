using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services;

public class MediaService
{
    private readonly List<Media> medias = new();

    public void AddMedia(Media media)
    {
        medias.Add(media);
    }

    public void DisplayAll()
    {
        foreach (var media in medias)
        {
            media.DisplayInfo();
        }
    }
}
