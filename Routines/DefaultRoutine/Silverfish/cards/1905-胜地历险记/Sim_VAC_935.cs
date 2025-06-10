using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：5 生命值：4
	//Carry-On Grub
	//随行肉虫
	//[x]<b>Battlecry:</b> Get a 1-CostSuitcase. Pack the top 2_cards of your deck into it.
	//<b>战吼：</b>获取一张法力值消耗为（1）的手提箱，将你牌库顶的2张牌装入其中。
	class Sim_VAC_935 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 假设衍生物“手提箱”的卡牌ID为 VAC_935t
            p.drawACard(CardDB.cardIDEnum.VAC_935t, own.own, true); // 抽取衍生物
        }
    }
}
