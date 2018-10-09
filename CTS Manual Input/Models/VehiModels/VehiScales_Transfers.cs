using CTS_Models;
using System.Collections.Generic;

namespace CTS_Manual_Input.Models.VehiModels
{
  public class VehiScales_Transfers
  {
    public List<VehiScale> VehiScales { get; set; }
    public PagedList.IPagedList<VehiTransfer> Transfers { get; set; }
  }
}