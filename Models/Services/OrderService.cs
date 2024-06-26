﻿using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.DataBase.MainModels.Order;
using HotelProject.Models.Interfaces;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class OrderService : IOrder
    {
        public List<Room> ActiveOrderList(bool badOrRoom, string? roomType)
        {
            string convertBadOrRoom = "havepeople IS NOT NULL";
            string convertRoomType = "";
            if(badOrRoom!=false)
            {
                convertBadOrRoom = "havepeople=0";
            }
            if(roomType!= "Active Rooms" && roomType != "")
            {
                convertRoomType = $"and roomtype='{roomType}'";
            }
            try
            {
                List<Room> activeRoomsModelDGV= DbContext.Query<Room>($"select * from \"EmployeControlData\".room\r\nwhere {convertBadOrRoom} {convertRoomType}");
                return activeRoomsModelDGV.ToList();
            }
            catch(Exception ex) 
            {
                throw;
            }
        }
        public List<RoomTypes> RoomTypesOrder()
        {
            
            try
            {
                List<RoomTypes> RoomTypeOrder = DbContext.Query<RoomTypes>("select   * from RoomTypes");
                return RoomTypeOrder.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Client> SearchClient(string passportId)
        {

            try
            {
                List<Client> searchClient = DbContext.Query<Client>($"select * from \"OrderData\".\"Client\"\r\nwhere passportid='{passportId}'");
                return searchClient.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
