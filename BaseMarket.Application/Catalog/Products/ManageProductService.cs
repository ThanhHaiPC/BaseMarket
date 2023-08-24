using BaseMarket.Application.Catalog.Products.DTOs;
using BaseMarket.Application.Catalog.Products.DTOs.Manage;
using BaseMarket.Application.Dtos;
using BaseMarket.Data.EF;
using BaseMarket.Data.Entities;
using BaseMarket.Utillties.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly MarketDbContext _context;
        public ManageProductService(MarketDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                ProductName = request.ProductName,
                Description = request.Description,
                ShortDesc = request.ShortDesc,
                Price = request.Price,
                Discount = request.Discount,
                HomeFlag = request.HomeFlag,
                BestSellers = request.BestSellers,
                Active = request.Active,
               
                Tags = request.Tags,
                Title = request.Title,
                Alias = request.Alias,
                MetaTitle = request.MetaTitle,
                MetaDes = request.MetaDes,
                MetaKey = request.MetaKey,
                UnitStock = request.UnitStock,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,

            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int ProductID)
        {
            var product = await _context.Products.FindAsync(ProductID);
            if (product == null) throw new BaseMarketException($"Cannot find a product: {ProductID}");
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public Task<PagedResult<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            // select join
            var query = from p in _context.Products
                        join pic in _context.ProductInCategories on p.ProductID equals pic.ProductID
                        join c in _context.Categories on pic.CategoryID equals c.CategoryID
                        select new { p, pic, c };
            //filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.p.ProductName.Contains(request.Keyword));
            }
            if (request.CategotyIDs.Count > 0)
            {
                query = query.Where(p => request.CategotyIDs.Contains(p.pic.CategoryID));
            }
            //Paging
            int TotalRow = await query.CountAsync();
            var data =await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x=> new ProductViewModel()
                {
                    ProductID = x.p.ProductID,
                    ProductName = x.p.ProductName,
                    Description =x .p.Description,
                    ShortDesc = x .p.ShortDesc,
                    Price = x .p.Price,
                    Discount  = x .p.Discount,
                    BestSellers = x .p.BestSellers,
                    Active = x .p.Active,
                    HomeFlag = x .p.HomeFlag,
               
                    UpdateDate = x .p.UpdateDate,
                    CreateDate = x .p.CreateDate,
                    Alias = x .p.Alias,
                    Tags  = x .p.Tags,
                    Title = x .p.Title,
                    MetaDes = x .p.MetaDes,
                    MetaTitle = x .p.MetaTitle,
                    MetaKey = x .p.MetaKey,
                    UnitStock   = x .p.UnitStock,
                }).ToListAsync();
            //Select and projection
            var pageResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = TotalRow,
                items = data
            };
            return pageResult;

         
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.ProductID);
            if (product == null) throw new BaseMarketException($"Cannot find a product with id :{request.ProductID}");
            product.ProductName= request.ProductName;
            product.Description= request.Description;
            product.ShortDesc = request.ShortDesc;
           
            product.BestSellers = request.BestSellers;
            product.HomeFlag= request.HomeFlag;
            product.Active  =   request.Active;
            product.MetaDes = request.MetaDes;
            product.MetaTitle = request.MetaTitle;
            product.MetaKey = request.MetaKey;
            product.Tags = request.Tags;
            product.Title = request.Title;
            product.Alias  = request.Alias;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int ProductID, int Price)
        {
            var product = await _context.Products.FindAsync(ProductID);
            if(product == null) throw new BaseMarketException($"Cannot find a product with id :{ProductID}");
            product.Price = Price;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateUnitStock(int ProductID, int Quantity)
        {
            var product = await _context.Products.FindAsync(ProductID);
            if (product == null) throw new BaseMarketException($"Cannot find a product with id :{ProductID}");
            product.UnitStock += Quantity;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
