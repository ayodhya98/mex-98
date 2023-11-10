using AutoMapper;
using BLL.Dto;
using BLL.Services.Interfaces;
using DAL.Repositories;
using DAL.Repositories.IRepository;

namespace BLL.Services
{
    public class CustomerService : ICustomerService

    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IMapper mapper, IUnitOfWork unitOfWork)
        {

            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ProductDto>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> CreateCustomer(CreateCustomerDto createCustomerDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<ProductDto>> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
