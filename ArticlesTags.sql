SELECT
	a.Topic,
	t.Name
FROM Articles a
LEFT JOIN TagsArticles ta ON ta.ArticleId = a.Id
LEFT JOIN Tags t ON ta.TagId = t.Id