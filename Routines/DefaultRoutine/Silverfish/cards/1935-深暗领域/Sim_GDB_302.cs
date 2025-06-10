using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：3 攻击力：3 生命值：1
	//Blazing Accretion
	//吸积炽焰
	//<b>Battlecry:</b> Destroy the top 3 cards of your deck. Any Fire spells or Elementals are drawn instead.
	//<b>战吼：</b>摧毁你牌库顶的3张牌，其中的火焰法术牌或元素牌会由摧毁改为抽取。
	class Sim_GDB_302 : SimTemplate
	{
        
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
			{
				//检测牌库是否有元素并抽取
				var drawElemental = p.CheckTurnDeckExists(TAG_RACE.ELEMENTAL); // 元素
				if (drawElemental != CardDB.cardIDEnum.None) p.drawACard(drawElemental, true); // 抽取元素
			} 
			else
            {
				p.drawACard(CardDB.cardIDEnum.None, true);
            }

        }
        
	}
}

