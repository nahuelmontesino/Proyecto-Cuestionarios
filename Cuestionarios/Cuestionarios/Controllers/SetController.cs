﻿using AutoMapper;
using Cuestionarios.DataAccessLayer;
using Cuestionarios.Domain;
using Cuestionarios.DTOs;
using System.Collections.Generic;


namespace Cuestionarios.Controllers
{

    public class SetController
    {
        private readonly UnitOfWork iUOfW = new UnitOfWork();

        /// <summary>
        /// Get a set by name
        /// </summary>
        public SetDTO GetSetByName(string name)
        {
            var set = iUOfW.SetRepository.GetSetByName(name);
            return Mapper.Map<Set, SetDTO>(set);
        }

        /// <summary>
        /// Get all sets
        /// </summary>
        public IEnumerable<SetDTO> GetAllSets()
        {
            List<SetDTO> result =  new List<SetDTO>();
            var sets =  iUOfW.SetRepository.Get();

            foreach (var set in sets)
            {
                result.Add(Mapper.Map<Set, SetDTO>(set));
            }

            return result;
        }
    }
}
