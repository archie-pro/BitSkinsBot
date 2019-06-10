using BotSkinsAPI.Models;
using BotSkinsAPI.Models.RequestModels;
using BotSkinsAPI.Helpers;
using NUnit.Framework;
using System;

namespace Tests.Services
{
	public class QueryBuilderTest
	{
		private QueryBuilder queryBuilder;

		[SetUp]
		public void Setup()
		{
			this.queryBuilder = new QueryBuilder();
		}

		[Test]
		public void ModelValuesAreNull_ReturnsEmptyString()
		{
			RequestModel model = new RequestModel();

			string result = queryBuilder.BuildQuery(model);

			Assert.AreEqual(string.Empty, result);
		}

		private static object[] buildQueryTestData = new object[]
		{
			new object[]
			{
				new RequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					AppId = "10"
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456&app_id=10"
			},
			new object[]
			{
				new RequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					AppId = null
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new RequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = string.Empty,
					AppId = null
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a"
			},
			new object[]
			{
				new PagedRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					Page = 5,
					PerPage = 30
				},
				"page=5&per_page=30&api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new PagedRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					Page = 5
				},
				"page=5&api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new PagedRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					Page = 5
				},
				"page=5&api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new ItemHistoryRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					Names = new string[] {"ak-47", "mp 5", "super_gun"},
					Delimiter = ","
				},
				"names=ak-47,mp%205,super_gun&delimeter=,&api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new ItemHistoryRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					Names = null
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new ItemHistoryRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					Names = new string[0]
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new WithdrawalRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					WithdrawalMethod = WithdrawalMethod.BankWire
				},
				"withdrawal_method=bank_wire&api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new InventoryOnSaleRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
					HasStickers= TripleChoice.Yes,
					IsStatTrak = TripleChoice.NeverMind,
					SortBy = SortByType.WearValue,
				},
				"sort_by=wear_value&order=desc&has_stickers=1&is_stattrak=0&is_souvenir=0&show_trade_delayed_items=0&api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new ItemsPricesRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					Code = "123456",
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new ItemsPricesRequestModel()
				{
					APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					ItemPriceArray = new Tuple<string, string>[]
					{
						new Tuple<string, string>("aaa111aaa","5.00"),
						new Tuple<string, string>("bbb111bbb","10.00")
					}
				},
				"item_ids=aaa111aaa,bbb111bbb&prices=5.00,10.00&api_key=0a0000a0-00aa-000a-a000-0000aaaa000a"
			}
		};

		[Test]
		[TestCaseSource("buildQueryTestData")]
		public void RequestModelPassed_ReturnsQueryString(RequestModel model, string expectedResult)
		{
			string result = queryBuilder.BuildQuery(model);

			Assert.AreEqual(expectedResult, result);
		}
	}
}