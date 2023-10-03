using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exam.DeliveriesManager
{
    public class DeliveriesManager : IDeliveriesManager
    {

        private Dictionary<string, Deliverer> deliverersById = new Dictionary<string, Deliverer>();
        private Dictionary<string, Package> packageById = new Dictionary<string, Package>();
        private Dictionary<string, string> packagesByDeliverer = new Dictionary<string, string>();

        public void AddDeliverer(Deliverer deliverer)
        {
            deliverersById.Add(deliverer.Id, deliverer);
        }

        public void AddPackage(Package package)
        {
            packageById.Add(package.Id, package);
        }

        public void AssignPackage(Deliverer deliverer, Package package)
        {
            if (!deliverersById.ContainsKey(deliverer.Id) || !packageById.ContainsKey(package.Id))
            {
                throw new ArgumentException();
            }
            packagesByDeliverer.Add(package.Id, deliverer.Id);
        }

        public bool Contains(Deliverer deliverer)
        {
            return deliverersById.ContainsKey(deliverer.Id);
        }

        public bool Contains(Package package)
        {
            return packageById.ContainsKey(package.Id);
        }

        public IEnumerable<Deliverer> GetDeliverers()
        {
            return deliverersById.Values;
        }

        public IEnumerable<Deliverer> GetDeliverersOrderedByCountOfPackagesThenByName()
        {
            var deliverersByPackageId = new Dictionary<string, int>();

            foreach(var kvp in packagesByDeliverer)
            {
                if(!deliverersByPackageId.ContainsKey(kvp.Value))
                {
                    deliverersByPackageId.Add(kvp.Value,0);
                }
                deliverersByPackageId[kvp.Value] += 1;
            }
            return deliverersByPackageId.OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => deliverersById[kvp.Key].Name)
                .Select(kvp => deliverersById[kvp.Key]); 
        }

        public IEnumerable<Package> GetPackages()
        {
            return packageById.Values;
        }

        public IEnumerable<Package> GetPackagesOrderedByWeightThenByReceiver()
        {
            return packageById.Values.OrderByDescending(package => package.Weight).ThenBy(package => package.Receiver);
        }

        public IEnumerable<Package> GetUnassignedPackages()
        {
            return packageById.Where(package => !packagesByDeliverer.ContainsKey(package.Key)).Select(package => package.Value);
        }
    }
}
