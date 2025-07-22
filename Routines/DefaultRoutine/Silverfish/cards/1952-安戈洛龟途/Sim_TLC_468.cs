using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：2 生命值：4
	//Blob of Tar
	//黏团焦油
	//[x]<b>Poisonous</b>, <b>Taunt</b><b>Deathrattle:</b> Summon a 1/2Blob with <b>Poisonous</b> and a1/2 Blob with <b>Taunt</b>.
	//<b>剧毒</b>。<b>嘲讽</b>。<b>亡语：</b>召唤一个1/2并具有<b>剧毒</b>的黏团，以及一个1/2并具有<b>嘲讽</b>的黏团。
	class Sim_TLC_468 : SimTemplate
	{
		CardDB.Card LankyBlob = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_468t1);
		CardDB.Card RobustBlob = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_468t2);
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(LankyBlob, m.zonepos -1, m.own);
			p.callKid(RobustBlob, m.zonepos -1, m.own);
		}
	}
}
