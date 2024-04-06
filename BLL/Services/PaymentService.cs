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
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public PaymentService(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public IEnumerable<PaymentDto> GetAll()
        {
            var payments = _paymentRepository.GetAll();
            return _mapper.Map<IEnumerable<PaymentDto>>(payments);
        }

        public void Add(PaymentDto paymentDTO)
        {
            var payment = _mapper.Map<Payment>(paymentDTO);
            _paymentRepository.Add(payment);
        }

        public void DeleteById(int paymentId)
        {
            _paymentRepository.Delete(paymentId);
        }

        public PaymentDto GetById(int id)
        {
            var payment = _paymentRepository.GetById(id);
            return _mapper.Map<PaymentDto>(payment);
        }

        public void Update(PaymentDto paymentDTO)
        {
            var payment = _mapper.Map<Payment>(paymentDTO);
            _paymentRepository.Update(payment);
        }
    }

}
