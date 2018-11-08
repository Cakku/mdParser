using System;
using System.Collections.Generic;
using System.Diagnostics;
using Markdig.Helpers;



public class BlockProcessor
{
    public StringSlice[] Document;

    public BlockProcessor(StringSlice[] document){
        Document = document;
    }

    public void ProcessLine(StringSlice line){
        //Todo
        Document.push(line);
    }
    

}