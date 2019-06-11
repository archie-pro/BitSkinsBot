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
		public void ModelIsNull_ReturnsEmptyString()
		{
			string result = queryBuilder.BuildQuery(null);

			Assert.AreEqual(string.Empty, result);
		}

		[Test]
		public void ModelValuesAreNull_ReturnsEmptyString()
		{
			RequestQueryModel model = new RequestQueryModel();

			string result = queryBuilder.BuildQuery(model);

			Assert.AreEqual(string.Empty, result);
		}

		private static object[] buildQueryTestData = new object[]
		{
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new RequestBodyModel()
					{
						AppId = "10"
					}
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456&app_id=10"
			},
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new RequestBodyModel()
					{
						AppId = null
					}
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = string.Empty,
					},
					RequestBodyParams = new RequestBodyModel()
					{
						AppId = null
					}
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a"
			},
			new object[]
			{
				new RequestQueryModel
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new PagedRequestModel()
					{
						Page = 5,
						PerPage = 30
					},
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456&page=5&per_page=30"
			},
			new object[]
			{
				new RequestQueryModel
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new PagedRequestModel()
					{
						Page = 5,
					},
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456&page=5"
			},
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new ItemHistoryRequestModel()
					{
						Names = new string[] {"ak-47", "mp 5", "super_gun"},
						Delimiter = ","
					}
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456&names=ak-47,mp%205,super_gun&delimeter=,"
			},
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new ItemHistoryRequestModel()
					{
						Names = null
					}
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new ItemHistoryRequestModel()
					{
						Names = new string[0]
					}
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new WithdrawalRequestModel()
					{
						WithdrawalMethod = WithdrawalMethod.BankWire
					}	
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456&withdrawal_method=bank_wire"
			},
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new InventoryOnSaleRequestModel()
					{
						HasStickers= TripleChoice.Yes,
						IsStatTrak = TripleChoice.NeverMind,
						SortBy = SortByType.WearValue,
					},
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456&sort_by=wear_value&order=desc&has_stickers=1&is_stattrak=0&is_souvenir=0&show_trade_delayed_items=0"
			},
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
						Code = "123456",
					},
					RequestBodyParams = new ItemsPricesRequestModel()
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&code=123456"
			},
			new object[]
			{
				new RequestQueryModel()
				{
					RequestAuthParams = new RequestAuthModel()
					{
						APIKey = "0a0000a0-00aa-000a-a000-0000aaaa000a",
					},
					RequestBodyParams = new ItemsPricesRequestModel()
					{
						ItemPriceArray = new Tuple<string, string>[]
						{
							new Tuple<string, string>("aaa111aaa","5.00"),
							new Tuple<string, string>("bbb111bbb","10.00")
						}
					}
				},
				"api_key=0a0000a0-00aa-000a-a000-0000aaaa000a&item_ids=aaa111aaa,bbb111bbb&prices=5.00,10.00"
			}
		};

		[Test]
		[TestCaseSource("buildQueryTestData")]
		public void RequestModelPassed_ReturnsQueryString(RequestQueryModel model, string expectedResult)
		{
			string result = queryBuilder.BuildQuery(model);

			Assert.AreEqual(expectedResult, result);
		}
	}
}