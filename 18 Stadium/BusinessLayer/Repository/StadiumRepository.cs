﻿using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Repository
{
    public class StadiumRepository : Repository<Stadium>
    {
        public IEnumerable<StadiumFormatVM> GetList(string StadiumName)
        {
            StadiumName = StadiumName.Trim();
            IEnumerable<Stadium> list = GetAll(c => c.isDeleted == false
                                            && c.Name.Contains(StadiumName));
            foreach (Stadium s in list)
            {
                yield return new StadiumFormatVM
                {
                    Id = s.Id,
                    Name = s.Name,
                    Price = s.Price.ToString("N0"),
                    Rentable = s.Rentable,
                    Area = s.Area,
                    Note = s.Note,
                    Image = s.Image,
                };
                /*yield return mapper.Map<StadiumVM>(s);*/
            }
        }

        public void AddStadium(StadiumVM c)
        {
            if (c.Validate().Length == 0)
            {
                Stadium s = mapper.Map<Stadium>(c);
                s.isDeleted = false;
                Add(s);
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void UpdateStadium(StadiumVM c)
        {
            if (c.Validate().Length == 0)
            {
                Stadium stadium = GetById(c.Id);
                mapper.Map(c, stadium);
                stadium.isDeleted = false;
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void DeleteStadium(int id)
        {
            Stadium stadium = GetById(id);
            stadium.isDeleted = true;
            Save();
        }

        //Dat san
        public IEnumerable<StadiumVM> GetListAvailable()
        {
            IEnumerable<Stadium> list = GetAll(c => c.isDeleted == false && c.Rentable == true);
            foreach (Stadium s in list)
            {
                yield return mapper.Map<StadiumVM>(s);
            }
        }
    }
}
