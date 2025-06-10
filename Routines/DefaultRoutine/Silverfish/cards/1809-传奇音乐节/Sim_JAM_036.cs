using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：5 生命值：5
	//Magatha, Bane of Music
	//乐坛灾星玛加萨
	//<b>Battlecry:</b> Draw 5 cards. Give any spells drawnto your opponent.
	//<b>战吼：</b>抽五张牌。将抽到的法术牌交给你的对手。
	class Sim_JAM_036 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own);
			p.drawACard(CardDB.cardIDEnum.None, own.own);
			p.drawACard(CardDB.cardIDEnum.None, own.own);
			p.drawACard(CardDB.cardIDEnum.None, own.own);
			p.drawACard(CardDB.cardIDEnum.None, own.own);
			
		}
		
	}
}
