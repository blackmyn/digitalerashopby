using AutoMapper;
using BLL.DTOModels;
using BLL.Interfaces;
using DLL.DB;
using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public IEnumerable<ReviewDto> GetAll()
        {
            var reviews = _reviewRepository.GetAll();
            return _mapper.Map<IEnumerable<ReviewDto>>(reviews);
        }

        public void Add(ReviewDto reviewDTO)
        {
            var review = _mapper.Map<Review>(reviewDTO);
            _reviewRepository.Add(review);
        }

        public void DeleteById(int reviewId)
        {
            _reviewRepository.Delete(reviewId);
        }

        public ReviewDto GetById(int id)
        {
            var review = _reviewRepository.GetById(id);
            return _mapper.Map<ReviewDto>(review);
        }

        public void Update(ReviewDto reviewDTO)
        {
            var review = _mapper.Map<Review>(reviewDTO);
            _reviewRepository.Update(review);
        }
        public IEnumerable<ReviewDto> GetByProductId(int productId)
        {
            var specifications = _reviewRepository.GetAll().Where(spec => spec.ProductId == productId);
            return _mapper.Map<IEnumerable<ReviewDto>>(specifications);
        }
    }

}
