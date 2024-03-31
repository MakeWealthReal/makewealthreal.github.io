﻿namespace MWRCheatSheet.ViewModel;

public class MegaSchoolPipeline : Pipeline<Model.MegaSchoolPipeline>
{
    public override string DisplayName(Model.MegaSchoolPipeline step) => step switch
    {
        Model.MegaSchoolPipeline.Enqueue => "Enqueue",
        Model.MegaSchoolPipeline.Share => "Ask + Share",
        Model.MegaSchoolPipeline.Invitation => "Invitation",
        Model.MegaSchoolPipeline.Decision => "Decision",
        _ => throw new NotImplementedException($"'{step}' has no display name defined")
    };
}
