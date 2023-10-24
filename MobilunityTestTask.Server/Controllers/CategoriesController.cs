using Microsoft.AspNetCore.Mvc;
using MobilunityTestTask.Server.Models;
using System.Text.Json;

namespace MobilunityTestTask.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            string path = $"{Environment.CurrentDirectory}\\Content\\Categories.json";

            using FileStream openStream = System.IO.File.OpenRead(path);

            var categories = await JsonSerializer.DeserializeAsync<List<Category>>(openStream);

            if (categories != null)
            {
                var response = CreateCategoryTree(categories);

                return Ok(response);
            }

            return BadRequest();
        }

        private List<CategoryNode> CreateCategoryTree(List<Category> categories)
        {
            List<CategoryNode> nodes = [];

            foreach (var item in categories)
            {
                if (item.ParentCategoryId == null)
                    nodes.Add(new CategoryNode { Id = item.CategoryId, Name = item.CategoryName });
                else
                {
                    CreateNode(nodes, item);
                }
            }
            return nodes;
        }

        private static void CreateNode(List<CategoryNode> nodes, Category parent)
        {
            foreach (var node in nodes)
            {
                if (node.Id == parent.ParentCategoryId)
                {
                    node.Children.Add(new CategoryNode { Id = parent.CategoryId, Name = parent.CategoryName });
                }
                else
                {
                    CreateNode(node.Children, parent);
                }
            }
        }
    }
}
