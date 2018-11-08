using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Markdig.Helpers;


public class Mdparser {
    private LineReader lineReader;
    private readonly BlockProcessor blockProcessor;
    private readonly InlineProcessor inlineProcessor;
    private  StringSlice[] document;


private Init(string text) {
    lineReader = new LineReader(text);
    blockProcessor = new BlockProcessor(document);


}

public string Parse(string text) {
    Init(text);
    ProcessLines();
    ProcessInLines();


}
//Process block elements in lines
private void ProcessLines() {
        while (true)
        {
            var textLine = lineReader.ReadLine();

            if (textLine == null)
                break;

            blockProcessor.ProcessLine(textLine);
        }

    }
    //Parse formatting for lines
private void ProcessInLines() {
    for (int i = 0; i < blockProcessor.Document.Length; i++ ) {

    }


}

}