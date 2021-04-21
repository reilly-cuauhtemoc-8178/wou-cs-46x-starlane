﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using iCollections.Models;
using iCollections.Data;
using System.IO;
using iCollections.Controllers;

namespace iCollections.Models
{

/*    [TempData]
    public string StatusMessage { get; set; }*/
    public partial class CreateCollectionModel2
    {
        //[TempData]
        [Required]
        public string Route { get; set; }

    }




    /*public partial class CreateCollectionPhotos
    {
        public CreateCollectionPhotos()
        {
            photosSelected = new HashSet<CreateCollectionPhotoId>();
        }
        
        public virtual ICollection<CreateCollectionPhotoId> photosSelected { get; set; }
    }


    public partial class CreateCollectionPhotoId
    {

        //[TempData]
        public int CollectionPhotoId { get; set; }
    }*/



    public partial class CreateCollectionPublishing
    {
        //[TempData]
        [Required]
        [Display(Name = "iCollection Name")]
        public string CollectionName { get; set; }

        //[TempData]
        [Display(Name = "Visibility")]
        public string Visibility { get; set; }

        //[TempData]
        public string Description { get; set; }
    }







    public partial class RendingTransfer
    {
        public RendingTransfer()
        {
            AllPhotos = new List<RenderingPhoto>();
        }

        public void AddPhoto(RenderingPhoto photo)
        {
            AllPhotos.Add(photo);
            //AllPhotos.Append(photo);  
        }

        public virtual List<RenderingPhoto> AllPhotos { get; set; }

    }

    public partial class RenderingPhoto
    {
        public string Data { get; set; }
        public string Title { get; set; }
        public int Rank { get; set; }
        public string Description { get; set; }

        public RenderingPhoto(string data, string title, int rank, string description)
        {
            Data = data;
            Title = title;
            Rank = rank;
            Description = description;
        }
    }



}