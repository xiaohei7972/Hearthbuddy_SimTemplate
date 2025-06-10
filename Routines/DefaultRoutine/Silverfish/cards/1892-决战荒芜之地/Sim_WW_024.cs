using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：4
	//Living Prairie
	//活体原野岩
	//[x]<b>Battlecry:</b> If you playedan Elemental last turn,summon two 3/3Cows with <b>Rush</b>.
	//<b>战吼：</b>如果你在上个回合使用过元素牌，召唤两只3/3并具有<b>突袭</b>的奶牛。
	class Sim_WW_024 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_024t);//murlocscout
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
			p.callKid(kid, own.zonepos, own.own);
		}
		
	}
}
