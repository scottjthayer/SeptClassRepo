import { TestBed } from '@angular/core/testing';

import { RedditAwwService } from './reddit-aww.service';

describe('RedditAwwService', () => {
  let service: RedditAwwService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RedditAwwService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
