﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.WebRegisterServices
{
    /// <summary>
    /// Summary description for WebRoleService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebRoleService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontex = new ModelUnibookContainer();


        [WebMethod]
        public void Insert(RoleDto roleDto)
        {
            try
            {
                RoleBrl.Insert(roleDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(RoleDto roleDto)
        {
            try
            {
                RoleBrl.Update(roleDto, dbcontex);
                //sdfsfsfs
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Delete(short id)
        {
            try
            {
                RoleBrl.Delete(id, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public RoleDto Get(short id)
        {
            RoleDto roleDto = null;
            try
            {
                roleDto = RoleBrl.GetDto(1, dbcontex);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return roleDto;

        }

        [WebMethod]
        public List<RoleDto> GetAll()
        {
            try
            {
                return RoleBrl.GetAll(dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
