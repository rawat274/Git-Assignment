using System;
using System.Collections.Generic;

namespace CSharp6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Equipment> equipments = new List<Equipment>();
            int ch = -1;
            while (ch != 12)
            {
                Console.WriteLine("1. Create an Equipment :– Mobile and Immobile.");
                Console.WriteLine("2. Delete an Equipment.");
                Console.WriteLine("3. Move an Equipment :– Mobile and Immobile.");
                Console.WriteLine("4. List all Equipment.");
                Console.WriteLine("5. Show details of an Equipment. ");
                Console.WriteLine("6. List all Mobile Equipment.");
                Console.WriteLine("7. List all Immobile Equipment.");
                Console.WriteLine("8. List all Equipment that have not been moved till now.");
                Console.WriteLine("9. Delete all Equipment.");
                Console.WriteLine("10. Delete all Immobile Equipment.");
                Console.WriteLine("11. Delete all Mobile Equipment.");
                Console.WriteLine("12. Exit");
                Console.Write("Enter your Choice:- \n");
                if (!int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("\nEnter a Correct Choice.\n");
                }
                else
                {
                    switch (ch)
                    {
                        case 1:  //Create an equipment – mobile and immobile
                            createEquipment(equipments);
                            break;
                        case 2:  //Delete an Equipment
                            deleteEquipment(equipments);
                            break;
                        case 3:  //Move an Equipment :– Mobile and Immobile
                            moveEquipment(equipments);
                            break;
                        case 4:  //List all Equipment
                            listAllEquipment(equipments);
                            break;
                        case 5: //Show details of an Equipment
                            showdetails(equipments);
                            break;
                        case 6: //List all Mobile Equipment
                            listAllMobileEquipment(equipments);
                            break;
                        case 7: //List all Immobile Equipment
                            listAllImmobileEquipment(equipments);
                            break;
                        case 8: //List all Equipment that have not been moved till now.
                            listAllEquipmentNotBeenMovedTillNow(equipments);
                            break;
                        case 9:  //Delete all equipment
                            equipments.Clear();
                            Console.WriteLine("\nAll equipments have been deleted.\n");
                            break;
                        case 10: // Delete all Immobile Equipment
                            equipments.RemoveAll(e => e is Immobile);
                            Console.WriteLine("\nAll Immobile equipments have been deleted.\n");
                            break;
                        case 11: //Delete all Mobile Equipment
                            equipments.RemoveAll(e => e is Mobile);
                            Console.WriteLine("\nAll Mobile equipments have been deleted.\n");
                            break;
                        case 12:   //Exit
                            break;
                        default:
                            Console.WriteLine("\nEnter a Correct Choice.\n");
                            break;
                    }
                }
            }
        }
        static void createEquipment(List<Equipment> equipments)
        {
            string name;
            string description;
            double mc;
            int ch;
            Console.WriteLine("1. Create a Mobile equipment:- \n");
            Console.WriteLine("2. Create an Immobile equipment:- \n");
            Console.WriteLine("Enter your Choice:- \n ");
            if (!int.TryParse(Console.ReadLine(), out ch) || ch < 1 || ch > 2)
            {
                Console.WriteLine("\nEnter a Correct Choice.\n");
            }
            else
            {
                Console.WriteLine("Enter the name:- \n");
                name = Console.ReadLine();
                Console.WriteLine("Enter the description:- \n");
                description = Console.ReadLine();
                Console.WriteLine("Enter the maintenance cost:- \n");
                if (!double.TryParse(Console.ReadLine(), out mc) || mc < 0)
                {
                    Console.WriteLine("\nEnter a correct maintenance cost:-\n");
                }
                if (ch == 1)
                {
                    equipments.Add(new Mobile(name, description, mc));
                }
                if (ch == 2)
                {
                    equipments.Add(new Immobile(name, description, mc));
                }
                Console.WriteLine("\nA new Equipment has been added.\n");
            }
        }
        static void deleteEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                listAllEquipment(equipments);
                int selectedMobileEquipment = -1;
                Console.WriteLine("Select the Equipment:- \n");
                if (!int.TryParse(Console.ReadLine(), out selectedMobileEquipment) || selectedMobileEquipment < 0 || selectedMobileEquipment > equipments.Count)
                {
                    Console.WriteLine("\nSelect a Correct Equipment.\n");
                }
                else
                {
                    equipments.RemoveAt(selectedMobileEquipment - 1);
                    Console.WriteLine("\nThe Equipment has been deleted.\n");
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added any Equipments yet.");
            }
            Console.WriteLine();
        }
        static void moveEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                listAllEquipment(equipments);
                int selectedMobileEquipment = -1;
                Console.WriteLine("Select the Mobile Equipment:- ");
                if (!int.TryParse(Console.ReadLine(), out selectedMobileEquipment) || selectedMobileEquipment < 0 || selectedMobileEquipment > equipments.Count)
                {
                    Console.WriteLine("\nSelect correct Mobile Equipment.\n");
                }
                else
                {
                    if (equipments[selectedMobileEquipment - 1] is Mobile)
                    {
                        int dm;
                        Console.WriteLine("Enter the distance to move Mobile Equipment:- \n ");
                        if (!int.TryParse(Console.ReadLine(), out dm) || dm < 0)
                        {
                            Console.WriteLine("\nEnter a Correct distance to move:- \n");
                        }
                        else
                        {
                            ((Mobile)equipments[selectedMobileEquipment - 1]).DistanceMoved = dm;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nSelect a Mobile Equipment.\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added any Equipments yet.");
            }
            Console.WriteLine();
        }
        static void listAllEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                Console.WriteLine("\n{0,-15}{1,-25}{2,-15}", "Serial No.", "Name", "Description");
                for (int i = 0; i < equipments.Count; i++)
                {
                    Console.WriteLine("{0,-15}{1,-25}{2,-15}", (i + 1), equipments[i].Name, equipments[i].Description);
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added any Equipments yet.");
            }
            Console.WriteLine();
        }
        static void showdetails(List<Equipment> equipments)
        {


            if (equipments.Count > 0)
            {
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", "Serial No.", "Type", "Name", "Description", "Cost");
                for (int i = 0; i < equipments.Count; i++)
                {
                    string type = "Immobile";
                    if (equipments[i] is Mobile)
                    {
                        type = "Mobile";
                    }
                    Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", (i + 1), type, equipments[i].Name, equipments[i].Description, equipments[i].MaintenanceCost);
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added any Equipments yet.");
            }
            Console.WriteLine();
        }
        static void listAllMobileEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                int i = 0;
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", "Serial No.", "Type", "Name", "Description", "Cost", "Distance moved");
                foreach (Equipment equipment in equipments.FindAll(e => e is Mobile))
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", (i + 1), "Mobile", equipment.Name, equipment.Description, equipment.MaintenanceCost, (((Mobile)equipment).DistanceMoved));
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added any Equipments yet.");
            }
            Console.WriteLine();
        }
        static void listAllImmobileEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                int i = 0;
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", "Serial No.", "Type", "Name", "Description", "Cost");
                foreach (Equipment equipment in equipments.FindAll(e => e is Immobile))
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", (i + 1), "Immobile", equipment.Name, equipment.Description, equipment.MaintenanceCost);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added any Equipments yet.");
            }
            Console.WriteLine();
        }
        static void listAllEquipmentNotBeenMovedTillNow(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                int i = 0;
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", "Serial No.", "Type", "Name", "Description", "Cost");
                foreach (Equipment equipment in equipments.FindAll(e => e is Mobile && (((Mobile)e).DistanceMoved) == 0))
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", (i + 1), "Mobile", equipment.Name, equipment.Description, equipment.MaintenanceCost);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added any Equipments yet.");
            }
            Console.WriteLine();
        }

    }
}
