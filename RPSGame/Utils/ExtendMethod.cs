using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS.Utils {
	static class ExtendMethod {
		public static IList<TResult> Map<T, TResult>(this IList<T> self, Converter<T, TResult> method) {
			var type = self.GetType();
			if (typeof(List<T>) == type) {
				return ((List<T>)self).ConvertAll(method);
			} else if (type == typeof(T[])) {
				return ExtendMethod.Map((T[])self, (Func<T, TResult>)(item => method(item)));
			} else {
				var list = (IList<TResult>)Activator.CreateInstance(type);
				foreach (var item in self) {
					list.Add(method(item));
				}
				return list;
			}
		}

		public static TResult[] Map<T, TResult>(this T[] self, Func<T, TResult> method) {
			var newArray = new TResult[self.Length];
			for (var i = 0; i < newArray.Length; i++) {
				newArray[i] = method(self[i]);
			}
			return newArray;
		}

	}
}
