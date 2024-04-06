using AutoMapper;
using BLL.DTOModels;
using BLL.Interfaces;
using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IMapper _mapper;

        public DeliveryService(IDeliveryRepository deliveryRepository, IMapper mapper)
        {
            _deliveryRepository = deliveryRepository;
            _mapper = mapper;
        }

        public IEnumerable<DeliveryDto> GetAll()
        {
            var deliveries = _deliveryRepository.GetAll();
            return _mapper.Map<IEnumerable<DeliveryDto>>(deliveries);
        }

        public void Add(DeliveryDto deliveryDTO)
        {
            var delivery = _mapper.Map<Delivery>(deliveryDTO);
            _deliveryRepository.Add(delivery);
        }

        public void DeleteById(int deliveryId)
        {
            _deliveryRepository.Delete(deliveryId);
        }

        public DeliveryDto GetById(int id)
        {
            var delivery = _deliveryRepository.GetById(id);
            return _mapper.Map<DeliveryDto>(delivery);
        }

        public void Update(DeliveryDto deliveryDTO)
        {
            var delivery = _mapper.Map<Delivery>(deliveryDTO);
            _deliveryRepository.Update(delivery);
        }
    }

}
