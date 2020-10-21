using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Klein
{
    //Enum of material types for surface
    enum DesktopMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };

    public class Desk
    {
        public const int BASE_PRICE = 200;
        public const int DRAWER_PRICE = 50;
        public const int DESKTOP_AREA_COST = 1;
        public const int BASE_SIZE = 1000;
        public const int WIDTH_MIN = 24;
        public const int WIDTH_MAX = 96;
        public const int DEPTH_MIN = 12;
        public const int DEPTH_MAX = 48;

        //Get constants
        public int GetBasePrice() { return BASE_PRICE; }
        public int GetDrawerPrice() { return DRAWER_PRICE; }
        public int GetDesktopAreaCost() { return DESKTOP_AREA_COST; }
        public int GetBaseSize() { return BASE_SIZE; }
        public int GetWidthMin() { return WIDTH_MIN; }
        public int GetWidthMax() { return WIDTH_MAX; }
        public int GetDepthMin() { return DEPTH_MIN; }
        public int GetDepthMax() { return DEPTH_MAX; }

        public int width = 0;
        public int depth = 0;
        public int drawerCount = 0;
        public string surfaceType = "";
        public int orderDays = 14;
        public int surfaceArea = 0;

        //Get and set width
        public int GetWidth() { return width; }
        public void SetWidth(int width) { this.width = width; }

        //Get and set depth
        public int GetDepth() { return depth; }
        public void SetDepth(int depth) { this.depth = depth; }

        //Get and set drawer count
        public int GetDrawerCount() { return drawerCount; }
        public void SetDrawerCount(int drawerCount) { this.drawerCount = drawerCount; }

        //Get and set surface type
        public string GetSurfaceType() { return surfaceType; }
        public void SetSurfacetype(string surfaceType) { this.surfaceType = surfaceType;  }

        //Get and set order days
        public int GetOrderDays() { return orderDays; }
        public void SetOrderDays(int orderDays) { this.orderDays = orderDays; }

        //Get and set surface area
        public int GetSurfaceArea() { return surfaceArea; }
        public void SetSurfaceArea(int surfaceArea) { this.surfaceArea = surfaceArea; }

        //Generic Desk constructor
        public Desk()
        {            
        }

        //Desk constructor with variables
        public Desk(int width, int depth, int drawerCount, string surfaceType) 
        {
            this.width = width;
            this.depth = depth;
            this.drawerCount = drawerCount;
            this.surfaceType = surfaceType;
        }

        //Calculate surface area
        public int CalculateSurfaceArea(int width, int depth)
        {
            surfaceArea = this.width * this.depth;
            return surfaceArea;
        }

        //Calculate area cost
        public int CalculateAreaCost(int width, int depth)
        {
            int area = CalculateSurfaceArea(width, depth);
            int cost = 0;
            if (area > BASE_SIZE)
            {
                int areaOverage = area - BASE_SIZE;
                cost = areaOverage * DESKTOP_AREA_COST;
            }
            return cost;
        }

        //Calculate drawer cost
        public int CalculateDrawerCost(int drawerCount)
        {
            int drawerCost = DRAWER_PRICE * drawerCount;
            return drawerCost;
        }

        //Get surface cost
        public int GetSurfaceCost(string surfaceType)
        {
            //Create variable to hold value
            int materialCost = 0;

            //Switch to get value
            switch (surfaceType)
            {
                case "Oak":
                    materialCost = (int)DesktopMaterial.Oak;
                    break;
                case "Laminate":
                    materialCost = (int)DesktopMaterial.Laminate;
                    break;
                case "Pine":
                    materialCost = (int)DesktopMaterial.Pine;
                    break;
                case "Rosewood":
                    materialCost = (int)DesktopMaterial.Rosewood;
                    break;
                case "Veneer":
                    materialCost = (int)DesktopMaterial.Veneer;
                    break;
            }

            return materialCost;
        }

        //Calculate shipping
        public int Calculateshipping(int orderDays, int width, int depth)
        {
            int area = CalculateSurfaceArea(width, depth);
            int cost = 0;
            if (orderDays == 14)
            {
                cost = 0;
            }
            else
            {
                if (area < BASE_SIZE)
                {
                    switch (orderDays)
                    {
                        case 3:
                            cost = 60;
                            break;
                        case 5:
                            cost = 40;
                            break;
                        case 7:
                            cost = 30;
                            break;
                    }
                }
                else if (area >= BASE_PRICE || area <= 2000)
                {
                    switch (orderDays)
                    {
                        case 3:
                            cost = 70;
                            break;
                        case 5:
                            cost = 50;
                            break;
                        case 7:
                            cost = 35;
                            break;
                    }
                }
                else
                {
                    switch (orderDays)
                    {
                        case 3:
                            cost = 80;
                            break;
                        case 5:
                            cost = 60;
                            break;
                        case 7:
                            cost = 40;
                            break;
                    }
                }
            }
      
            return cost;
        }

        //Calculate desk cost
        public int CalculateDeskCost(int width, int depth, 
            int drawerCount, string surfaceType)
        {
            int basePrice = BASE_PRICE;
            int areaCost = CalculateAreaCost(width, depth);
            int drawerCost = CalculateDrawerCost(drawerCount);
            int surfaceCost = GetSurfaceCost(surfaceType);
            int totalCost = basePrice + areaCost + drawerCost + surfaceCost;
            return totalCost;
        }
    } 
}
