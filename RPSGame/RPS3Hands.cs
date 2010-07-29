using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml.Linq;

namespace RPS {
	class RPS3Hands : IHands {
		private Hand[] hands;
		private static XElement xml = XElement.Load(string.Format(@"..\..\Games\RPS3Hands.xml"));

		// MEMO 実験的にHandをXMLから読み込んでみるようにしました。enumとどっちがいいか決めかねています。
		public RPS3Hands() {
			hands = (
				from p in xml.Elements()
				select new Hand(p.Attribute("name").Value) {
					WinList = p.Element("wins").Elements("hand").ToList().ConvertAll(hand => new Hand(hand.Attribute("name").Value)),
				}).ToArray();
		}

		public int HandNum {
			get { return hands.Length; }
		}

		public Hand this[int index] {
			get { return hands[index]; }
		}

		public IEnumerator<Hand> GetEnumerator() {
			foreach (var hand in hands) {
				yield return hand;
			}
		}

		IEnumerator IEnumerable.GetEnumerator() {
			foreach (var hand in hands) {
				yield return hand;
			}
		}
	}
}
