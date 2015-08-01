﻿//-----------------------------------------------------------------------
// <copyright file="Q12844Tests.cs" company="CompanyName">
//     Copyright (c) Ching Hsu, CompanyName. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

// https://uva.onlinejudge.org/external/128/12844.pdf
// Q12844 Outwitting the Weighing Machine
// Some school children discovered that by getting on
// a weighing machine in couples, and then exchanging
// places—one at a time—they could get the correct weight
// of a whole party on the payment of but one cent. They
// found that in couples they weighed (in pounds): 129,
// 125, 124, 123, 122, 121, 120, 118, 116 and 114. What
// was the weight of each one of the fve little girls if taken
// separately?
// It proves that they must have been clever scholars or
// they never would have been able to work out the correct
// answer to such an interesting puzzle question, which is liable to confuse older heads than theirs.
// Given a list of 10 integers, representing the weighs of each couple formed from a group of 5 people,
// determine the weights of each person.

// Input
// Input starts with a positive integer T, that denotes the number of test cases. Each test case is described
// by 10 integers W1, W2, …, W10 in a single line.
// T ≤ 3000; 100 ≤ W1 ≤ W2 ≤ . . . ≤ W10 ≤ 400

// Output
// For each test case, print the case number, followed by the 5 weights asked, separated by spaces. Print
// these numbers in ascending order.

// Sample Input
// 3
// 114 116 118 120 121 122 123 124 125 129
// 110 111 114 115 118 118 119 122 123 126
// 180 190 190 196 196 206 216 216 226 232

// Sample Output
// Case 1: 56 58 60 64 65
// Case 2: 53 57 58 61 65
// Case 3: 90 90 100 106 126
namespace UnitTestProject
{
    using System;
    using CSharpLibrary;
    using FSharpLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Q12844Tests
    {
        [TestMethod]
        public void Q12844CSTest1()
        {
            // arrange
            var input =
@"114 116 118 120 121 122 123 124 125 129
110 111 114 115 118 118 119 122 123 126
180 190 190 196 196 206 216 216 226 232";
            var expected  =
@"Case 1: 56 58 60 64 65
Case 2: 53 57 58 61 65
Case 3: 90 90 100 106 126
";

            // act
            var actual = Q12844CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Q12844CSTest2()
        {
            // arrange
            var input =
@"362 320 236 360 340 256 380 214 338 254
262 244 205 238 264 225 258 207 240 201
228 172 214 295 176 218 299 162 243 285
235 275 324 252 178 227 155 267 195 244
213 217 300 214 194 277 191 281 195 278
229 141 254 159 210 323 228 235 140 253
317 240 294 330 211 265 301 188 224 278
248 153 185 130 289 321 266 226 171 203
354 304 338 253 330 364 279 314 229 263
259 230 301 215 245 316 230 287 201 272
240 282 338 220 234 290 172 332 214 270
253 357 375 377 246 264 266 368 370 388
217 187 119 135 302 234 250 204 220 152
167 169 233 247 150 214 228 216 230 294
200 239 284 171 243 288 175 327 214 259
285 341 265 263 266 190 188 246 244 168
231 182 192 224 307 317 349 268 300 310
274 343 280 266 311 248 234 317 303 240
310 260 303 329 202 245 271 195 221 264
271 280 246 209 329 295 258 304 267 233
301 270 180 286 331 241 347 210 316 226
361 243 304 246 258 319 261 201 143 204
233 151 279 172 182 310 203 228 121 249
300 311 327 224 273 289 186 300 197 213
191 184 129 109 271 216 196 209 189 134
212 242 269 146 302 329 206 359 236 263
176 262 224 184 312 274 234 360 320 282
295 273 346 226 240 313 193 291 171 244
214 276 262 189 226 212 139 274 201 187
261 301 267 216 236 202 151 242 191 157
247 284 213 274 247 176 237 213 274 203
244 212 257 234 162 207 184 175 152 197
206 233 164 164 273 204 204 231 231 162
266 234 199 245 358 323 369 291 337 302
234 228 291 312 112 175 196 169 190 253
139 243 209 191 262 228 210 332 314 280
274 370 311 295 272 213 197 309 293 234
182 267 241 243 223 197 199 282 284 258
352 241 330 383 211 300 353 189 242 331
240 266 277 167 342 353 243 379 269 280
324 249 315 237 259 325 247 250 172 238
348 288 340 296 278 330 286 270 226 278
333 344 361 255 299 316 210 327 221 238
146 146 226 224 170 250 248 250 248 328
318 285 327 256 277 319 248 286 215 257
307 312 208 299 393 289 380 294 385 281
283 235 208 241 352 325 358 277 310 283
285 308 271 243 229 192 164 215 187 150
268 344 334 390 230 220 276 296 352 342
323 250 221 287 235 206 272 133 199 170
358 263 307 319 235 279 291 184 196 240
287 229 222 181 292 285 244 227 186 179
246 169 155 170 211 197 212 120 135 121
357 293 271 245 304 282 256 218 192 170
215 226 211 308 183 168 265 179 276 261
292 223 218 143 329 324 249 255 180 175
315 362 265 379 281 184 298 231 345 248
214 242 242 275 282 282 315 310 343 343
229 304 361 231 187 244 114 319 189 246
307 337 211 202 350 224 215 254 245 119
205 152 167 235 235 250 318 197 265 280
216 239 214 140 321 296 222 319 245 220
313 309 305 328 280 276 299 272 295 291
289 202 189 241 255 242 294 155 207 194
263 201 223 250 322 344 371 282 309 331
232 272 261 247 232 221 207 261 247 236
275 193 323 331 186 316 324 234 242 372
373 312 317 317 337 342 342 281 281 286
273 244 257 355 197 210 308 181 279 292
355 355 265 374 328 238 347 238 347 257
181 258 250 281 267 259 290 336 367 359
247 237 231 322 188 182 273 172 263 257
324 257 300 303 281 324 327 257 260 303
215 243 277 157 270 304 184 332 212 246
231 216 216 278 265 265 327 250 312 312
234 267 199 259 263 195 255 228 288 220
247 313 231 210 300 218 197 284 263 181
373 306 240 255 327 261 276 194 209 143
263 153 258 212 214 319 273 209 163 268
203 333 254 334 230 151 231 281 361 282
333 311 306 257 262 257 208 235 186 181
290 237 159 169 313 235 245 182 192 114
200 196 269 251 258 331 313 327 309 382
333 335 243 347 352 260 364 262 366 274
191 205 111 147 286 192 228 206 242 148
217 149 246 118 250 347 219 279 151 248
250 223 213 162 331 321 270 294 243 233
364 238 263 366 268 293 396 167 270 295
195 211 241 194 242 272 225 288 241 271
225 196 194 258 203 201 265 172 236 234
163 158 247 167 175 264 184 259 179 268
307 178 291 293 235 348 350 219 221 334
251 207 226 192 332 351 317 307 273 292
310 306 237 356 250 181 300 177 296 227
207 206 320 314 171 285 279 284 278 392
253 253 327 286 214 288 247 288 247 321
108 233 143 230 231 141 228 266 353 263
236 227 147 201 319 239 293 230 284 204
208 236 185 319 200 149 283 177 311 260
387 315 304 391 320 309 396 237 324 313";
            var expected =
@"Case 1: 65 149 171 189 191
Case 2: 84 117 121 123 141
Case 3: 60 102 112 116 183
Case 4: 69 86 109 158 166
Case 5: 95 96 99 118 182
Case 6: 61 79 80 149 174
Case 7: 67 121 144 157 173
Case 8: 56 74 97 129 192
Case 9: 89 140 164 174 190
Case 10: 93 108 122 137 179
Case 11: 76 96 138 144 194
Case 12: 71 175 182 193 195
Case 13: 51 68 84 136 166
Case 14: 74 76 93 140 154
Case 15: 73 98 102 141 186
Case 16: 83 85 105 161 180
Case 17: 53 129 139 171 178
Case 18: 113 121 127 153 190
Case 19: 76 119 126 145 184
Case 20: 98 111 135 160 169
Case 21: 60 120 150 166 181
Case 22: 70 73 131 173 188
Case 23: 50 71 101 132 178
Case 24: 55 131 142 158 169
Case 25: 52 57 77 132 139
Case 26: 70 76 136 166 193
Case 27: 63 113 121 161 199
Case 28: 62 109 131 164 182
Case 29: 57 82 130 132 144
Case 30: 53 98 104 138 163
Case 31: 71 105 132 142 142
Case 32: 65 87 97 110 147
Case 33: 81 81 83 123 150
Case 34: 71 128 163 174 195
Case 35: 53 59 116 137 175
Case 36: 60 79 131 149 183
Case 37: 88 109 125 184 186
Case 38: 69 113 128 130 154
Case 39: 50 139 161 191 192
Case 40: 82 85 158 184 195
Case 41: 80 92 157 158 167
Case 42: 109 117 161 169 179
Case 43: 66 144 155 172 189
Case 44: 61 85 85 163 165
Case 45: 93 122 155 163 164
Case 46: 95 113 186 194 199
Case 47: 83 125 152 158 200
Case 48: 61 89 103 126 182
Case 49: 77 143 153 191 199
Case 50: 52 81 118 154 169
Case 51: 70 114 126 165 193
Case 52: 69 110 112 117 175
Case 53: 53 67 68 102 144
Case 54: 72 98 120 173 184
Case 55: 82 86 97 129 179
Case 56: 50 93 125 130 199
Case 57: 67 117 164 181 198
Case 58: 87 127 155 155 188
Case 59: 56 58 131 173 188
Case 60: 55 64 147 160 190
Case 61: 61 91 106 144 174
Case 62: 67 73 147 149 172
Case 63: 134 138 142 157 171
Case 64: 71 84 118 123 171
Case 65: 71 130 152 179 192
Case 66: 96 111 125 136 136
Case 67: 52 134 141 182 190
Case 68: 138 143 143 174 199
Case 69: 84 97 113 160 195
Case 70: 74 164 164 183 191
Case 71: 86 95 164 172 195
Case 72: 83 89 99 148 174
Case 73: 107 150 150 153 174
Case 74: 63 94 121 149 183
Case 75: 91 125 125 140 187
Case 76: 80 115 119 140 148
Case 77: 80 101 117 130 183
Case 78: 64 79 130 176 197
Case 79: 52 101 111 157 162
Case 80: 50 101 153 180 181
Case 81: 66 115 120 142 191
Case 82: 52 62 107 130 183
Case 83: 69 127 131 182 200
Case 84: 85 158 175 177 189
Case 85: 55 56 92 136 150
Case 86: 58 60 91 159 188
Case 87: 71 91 142 152 179
Case 88: 71 96 167 197 199
Case 89: 82 112 113 129 159
Case 90: 85 87 109 116 149
Case 91: 73 85 90 94 174
Case 92: 53 125 166 168 182
Case 93: 63 129 144 163 188
Case 94: 54 123 127 173 183
Case 95: 85 86 121 193 199
Case 96: 107 107 140 146 181
Case 97: 53 55 88 175 178
Case 98: 72 75 129 155 164
Case 99: 63 86 114 122 197
Case 100: 113 124 191 196 200
";

            // act
            var actual = Q12844CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}