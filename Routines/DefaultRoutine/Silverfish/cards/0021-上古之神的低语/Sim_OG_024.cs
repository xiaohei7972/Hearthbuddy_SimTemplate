using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_024 : SimTemplate //* 投火无面者 Flamewreathed Faceless
//<b>Overload:</b> (2)
//<b>过载：</b>（2） 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.ueberladung += 2;
		}
	}
}