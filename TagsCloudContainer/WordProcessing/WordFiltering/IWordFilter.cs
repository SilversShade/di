﻿namespace TagsCloudContainer.WordProcessing.WordFiltering;

public interface IWordFilter
{
    public string[] FilterWords(string[] words);
}