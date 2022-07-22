﻿using Medical.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.ViewModel
{
    public class NNewsViewModel
    {
       
        private News _news;
        public NNewsViewModel()
        {
            _news = new News();
        }
        public News news
        {
            get { return _news; }
            set { _news = value; }
        }
        public int No
        {
            get { return _news.No; }
            set { _news.No = value; }
        }
        public int? AdminId
        {
            get { return _news.AdminId; }
            set { _news.AdminId = value; }
        }
        public int? NewsCategoryId
        {
            get { return _news.NewsCategoryId; }
            set { _news.NewsCategoryId = value; }
        }
        public string NewsTitle
        {
            get { return _news.NewsTitle; }
            set { _news.NewsTitle = value; }
        }
        public string NewsContent
        {
            get { return _news.NewsContent; }
            set { _news.NewsContent = value; }
        }

        public string NewsPicturePath
        {
            get { return _news.NewsPicturePath; }
            set { _news.NewsPicturePath = value; }
        }
        public IFormFile photo { get; set; }

        public DateTime? CreateDate
        {
            get { return _news.CreateDate; }
            set { _news.CreateDate = value; }
        }
        public virtual Administarator Admin
        {
            get { return _news.Admin; }
            set { _news.Admin = value; }
        }
        public virtual Newscategory NewsCategory
        {
            get { return _news.NewsCategory; }
            set { _news.NewsCategory = value; }
        }
    }
}
