﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackerModuleV1._0.Content
{
    public class functions
    {
        public string createPartNumber()
        {
            string PartNumber = "";




            return PartNumber;
            
        }
    }

    public enum PartType
    {
        Document=1,
        Record=2,
        Mechanical_Part=3,
        Electrical_or_Electronic_Part=4,
        Penumatic_Part=5,
        Material_Part=6,
        Tools_Part=7,
        Test_and_Measurement_Equipment_Part=8,
        Other=9

    }
    public enum Document_SubCategory
    {
        Product_Definition = 100,
        Concept_Proposal= 101,
        Technical_Specification= 102 ,
        Technical_Proposal=103, 
        Mechanical_Design_Document=104,
        Mechanical_Design_Document_3d_Diagram= 201,
        Mechanical_Design_Document_2dDiagram= 202,
        Mechanical_Design_Document_BOM= 203,
        Mechanical_Design_Document_Assy_Diagram= 204,
        Mechanical_Design_Document_Assy_Instruction=205 

    }

    public enum Record_SubCategory
    {
        Mechanical_Design_Review_Record= 200,
        Mechanical_Design_Review_Record_3d_Diagram= 201,
        Review_Summary= 001,
        Evaluation_Results= 002,
        Verification_and_Validation_Results= 003,
        Simulation_Results= 004,
        Ceritfication= 005
    }
}