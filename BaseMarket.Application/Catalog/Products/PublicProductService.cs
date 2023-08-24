using BaseMarket.ViewModels.Catalog.Products.DTOs.Public;
using BaseMarket.ViewModels.Dtos;
using BaseMarket.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseMarket.ViewModels.Common;

namespace BaseMarket.ViewModels.Catalog.Products
{

    public class PublicProductService : IPublicProductService
    {
        private readonly MarketDbContext _context;
        public PublicProductService(MarketDbContext context)
        {
            _context = context;
        }
        public async Task<PagedResult<ProductViewModel>> GetAllByCategaryID(GetProductPagingRequest request)
        {
            // select join
            var query = from p in _context.Products
                        join pic in _context.ProductInCategories on p.ProductID equals pic.ProductID
                        join c in _context.Categories on pic.CategoryID equals c.CategoryID
                        select new { p, pic, c };
            //filter          
            if (request.CategoryID.HasValue && request.CategoryID.Value > 0)
            {
                query = query.Where(p => p.pic.CategoryID == request.CategoryID);
            }
            //Paging
            int TotalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    ProductID = x.p.ProductID,
                    ProductName = x.p.ProductName,
                    Description = x.p.Description,
                    ShortDesc = x.p.ShortDesc,
                    Price = x.p.Price,
                    Discount = x.p.Discount,
                    BestSellers = x.p.BestSellers,
                    Active = x.p.Active,
                    HomeFlag = x.p.HomeFlag,
                    UpdateDate = x.p.UpdateDate,
                    CreateDate = x.p.CreateDate,
                    Alias = x.p.Alias,
                    Tags = x.p.Tags,
                    Title = x.p.Title,
                    MetaDes = x.p.MetaDes,
                    MetaTitle = x.p.MetaTitle,
                    MetaKey = x.p.MetaKey,
                    UnitStock = x.p.UnitStock,
                }).ToListAsync();
            //Select and projection
            var pageResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = TotalRow,
                items = data
            };
            return pageResult;

        }


    }
}
