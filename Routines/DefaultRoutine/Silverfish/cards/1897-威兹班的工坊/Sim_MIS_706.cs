using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：3 攻击力：3 生命值：2
	//Dust Bunny
	//滚灰兔
	//[x]<b>Battlecry and Deathrattle:</b>Add a random piece of junkto your hand <i>(a Coin, Rock,Banana, or Knife)</i>.
	//<b>战吼，亡语：</b>将一件垃圾置入你的手牌<i>（幸运币，石头，香蕉或短刀）</i>。
	class Sim_MIS_706 : SimTemplate
	{

        private static Random rng = new Random();  // 随机数生成器

        // 战吼效果
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 向手牌添加一件随机垃圾
            addRandomJunkToHand(p, own.own);
        }

        // 亡语效果
        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 向手牌添加一件随机垃圾
            addRandomJunkToHand(p, m.own);
        }

        // 添加随机垃圾到手牌的方法
        private void addRandomJunkToHand(Playfield p, bool ownplay)
        {
            // 定义可能的垃圾卡牌ID
            List<CardDB.cardIDEnum> junkCards = new List<CardDB.cardIDEnum>
        {
            CardDB.cardIDEnum.GAME_005,  // 幸运币
            CardDB.cardIDEnum.WW_001t,   // 石头
            CardDB.cardIDEnum.EX1_014t,  // 香蕉
            CardDB.cardIDEnum.CS2_082,   // 短刀
        };

            // 随机选择一张垃圾卡牌
            CardDB.cardIDEnum randomJunk = junkCards[rng.Next(junkCards.Count)];

            // 添加随机垃圾到手牌
            p.drawACard(randomJunk, ownplay, true);
        }
    }
}
