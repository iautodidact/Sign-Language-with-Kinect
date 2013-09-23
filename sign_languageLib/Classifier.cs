﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Classifier
{
    private SegmentationModule _segmentationModule;
	public  SegmentationModule m_segmentationModule
	{
        get { return _segmentationModule; }
	}

    private NLPModule _NLPModule;
	public  NLPModule m_NLPModule
	{
        get { return _NLPModule; }
	}

    public LeariningModel m_leariningModel
    {
        get;
        set;
    }

    private GestureModule _gestureModule;
    public GestureModule m_gestureModule
	{
        get { return _gestureModule; }
	}

    private FeatureSelector _featureSelector;
    public FeatureSelector m_featureSelector
    {
        get { return _featureSelector; }
    }

    private DataProcessor _dataProcessor;
    public DataProcessor m_dataProcessor
    {
        get { return _dataProcessor; }
    }
    

  

    public Classifier()
    {
        _dataProcessor = new DataProcessor();
        _gestureModule = new GestureModule(this);
        _segmentationModule = new SegmentationModule(this);
        _featureSelector = new FeatureSelector();
        _NLPModule = new NLPModule();
        m_gestureModule.m_dataTransferEvent += m_segmentationModule.OnDataTransfer;
        m_dataProcessor.m_dataTransferEvent += m_segmentationModule.OnNewFrameDataReady;
        m_dataProcessor.m_dataTransferEvent += m_gestureModule.OnNewFrameDataReady;
    }

    public void Begin()
    {
       
        //m_gestureModule.BeginTest();
    }

}
