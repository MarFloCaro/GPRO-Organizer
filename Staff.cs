 
// Type: go.Staff
 
 
 

using go.Enums;
using go.History;
using System;
using System.Collections;

#nullable disable
namespace go
{
  [Serializable]
  public class Staff
  {
    public int overall;
    public int experience;
    public int motivation;
    public int technicalSkill;
    public int stressHandling;
    public int concentration;
    public int efficiency;
    public int windtunnel;
    public int pitstopTrainingCenter;
    public int rDWorkshop;
    public int rDDesignCenter;
    public int engineeringWorkshop;
    public int alloyAndChemicalLab;
    public int commercial;
    public int salary;
    public int maintenance;

    public bool IsDifferent(Staff s)
    {
      return s.overall != this.overall || s.experience != this.experience || s.motivation != this.motivation || s.technicalSkill != this.technicalSkill || s.stressHandling != this.stressHandling || s.concentration != this.concentration || s.efficiency != this.efficiency || s.windtunnel != this.windtunnel || s.pitstopTrainingCenter != this.pitstopTrainingCenter || s.rDWorkshop != this.rDWorkshop || s.rDDesignCenter != this.rDDesignCenter || s.engineeringWorkshop != this.engineeringWorkshop || s.alloyAndChemicalLab != this.alloyAndChemicalLab || s.commercial != this.commercial || s.salary != this.salary || s.maintenance != this.maintenance;
    }

    public void UpdateHistory(Date date, ref ArrayList history, Staff s)
    {
      if (s.overall != this.overall)
      {
        history.Add((object) new StaffHistory(date, this.overall, s.overall, StaffType.Overall));
        this.overall = s.overall;
      }
      if (s.experience != this.experience)
      {
        history.Add((object) new StaffHistory(date, this.experience, s.experience, StaffType.Experience));
        this.experience = s.experience;
      }
      if (s.motivation != this.motivation)
      {
        history.Add((object) new StaffHistory(date, this.motivation, s.motivation, StaffType.Motivation));
        this.motivation = s.motivation;
      }
      if (s.technicalSkill != this.technicalSkill)
      {
        history.Add((object) new StaffHistory(date, this.technicalSkill, s.technicalSkill, StaffType.TechnicalSkill));
        this.technicalSkill = s.technicalSkill;
      }
      if (s.stressHandling != this.stressHandling)
      {
        history.Add((object) new StaffHistory(date, this.stressHandling, s.stressHandling, StaffType.StressHandling));
        this.stressHandling = s.stressHandling;
      }
      if (s.concentration != this.concentration)
      {
        history.Add((object) new StaffHistory(date, this.concentration, s.concentration, StaffType.Concentration));
        this.concentration = s.concentration;
      }
      if (s.efficiency != this.efficiency)
      {
        history.Add((object) new StaffHistory(date, this.efficiency, s.efficiency, StaffType.Efficiency));
        this.efficiency = s.efficiency;
      }
      if (s.windtunnel != this.windtunnel)
      {
        history.Add((object) new StaffHistory(date, this.windtunnel, s.windtunnel, StaffType.Windtunnel));
        this.windtunnel = s.windtunnel;
      }
      if (s.pitstopTrainingCenter != this.pitstopTrainingCenter)
      {
        history.Add((object) new StaffHistory(date, this.pitstopTrainingCenter, s.pitstopTrainingCenter, StaffType.PitstopTrainingCenter));
        this.pitstopTrainingCenter = s.pitstopTrainingCenter;
      }
      if (s.rDWorkshop != this.rDWorkshop)
      {
        history.Add((object) new StaffHistory(date, this.rDWorkshop, s.rDWorkshop, StaffType.RDWorkshop));
        this.rDWorkshop = s.rDWorkshop;
      }
      if (s.rDDesignCenter != this.rDDesignCenter)
      {
        history.Add((object) new StaffHistory(date, this.rDDesignCenter, s.rDDesignCenter, StaffType.RDDesignCenter));
        this.rDDesignCenter = s.rDDesignCenter;
      }
      if (s.engineeringWorkshop != this.engineeringWorkshop)
      {
        history.Add((object) new StaffHistory(date, this.engineeringWorkshop, s.engineeringWorkshop, StaffType.EngineeringWorkshop));
        this.engineeringWorkshop = s.engineeringWorkshop;
      }
      if (s.alloyAndChemicalLab != this.alloyAndChemicalLab)
      {
        history.Add((object) new StaffHistory(date, this.alloyAndChemicalLab, s.alloyAndChemicalLab, StaffType.AlloyAndChemicalLab));
        this.alloyAndChemicalLab = s.alloyAndChemicalLab;
      }
      if (s.commercial != this.commercial)
      {
        history.Add((object) new StaffHistory(date, this.commercial, s.commercial, StaffType.Commercial));
        this.commercial = s.commercial;
      }
      if (s.salary != this.salary)
      {
        history.Add((object) new StaffHistory(date, this.salary, s.salary, StaffType.Salary));
        this.salary = s.salary;
      }
      if (s.maintenance == this.maintenance)
        return;
      history.Add((object) new StaffHistory(date, this.maintenance, s.maintenance, StaffType.Maintenance));
      this.maintenance = s.maintenance;
    }

    public Staff Clone()
    {
      return new Staff()
      {
        overall = this.overall,
        experience = this.experience,
        motivation = this.motivation,
        technicalSkill = this.technicalSkill,
        stressHandling = this.stressHandling,
        concentration = this.concentration,
        efficiency = this.efficiency,
        windtunnel = this.windtunnel,
        pitstopTrainingCenter = this.pitstopTrainingCenter,
        rDWorkshop = this.rDWorkshop,
        rDDesignCenter = this.rDDesignCenter,
        engineeringWorkshop = this.engineeringWorkshop,
        alloyAndChemicalLab = this.alloyAndChemicalLab,
        commercial = this.commercial,
        salary = this.salary,
        maintenance = this.maintenance
      };
    }
  }
}
