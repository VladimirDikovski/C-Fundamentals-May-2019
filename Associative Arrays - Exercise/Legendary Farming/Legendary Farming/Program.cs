using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var PlateMaterials = new Dictionary<string, int>();
            var JunkMaterials = new Dictionary<string, int>();
          
            PlateMaterials["fragments"] = 0;
            PlateMaterials["shards"] = 0;
            PlateMaterials["motes"] = 0;
            bool isenoughtMaterial = false;

            while (true)
            {
                if (isenoughtMaterial)
                {
                    break;
                }

                string[] input = Console.ReadLine().ToLower().Split(" ");
              
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quontyty = int.Parse(input[i]);
                    string material = input[i + 1];
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (!PlateMaterials.ContainsKey(material))
                        {
                            PlateMaterials[material] = quontyty;
                        }

                        else
                        {
                            PlateMaterials[material] += quontyty;
                        }
                        if (PlateMaterials[material] >= 250)
                        {
                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                PlateMaterials[material] -= 250;
                                isenoughtMaterial = true;
                                break;
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                                PlateMaterials[material] -= 250;
                                isenoughtMaterial = true;
                                break;
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                PlateMaterials[material] -= 250;
                                isenoughtMaterial = true;
                                break;
                            }

                        }
                    }
                    else
                    {
                        if (!JunkMaterials.ContainsKey(material))
                        {
                            JunkMaterials[material] = quontyty;
                        }
                        else
                        {
                            JunkMaterials[material] += quontyty;
                        }
                    }


                }
            }

           
            var filterDict = PlateMaterials.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in filterDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var filterJunkDict = JunkMaterials.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in filterJunkDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
