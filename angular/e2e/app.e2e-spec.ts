import { ChopstickDockerTemplatePage } from './app.po';

describe('ChopstickDocker App', function() {
  let page: ChopstickDockerTemplatePage;

  beforeEach(() => {
    page = new ChopstickDockerTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
